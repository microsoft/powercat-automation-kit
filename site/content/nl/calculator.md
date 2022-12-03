---
title: "Rekenmachine"
description: "Automatiseringskit - Rekenmachine"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: F0F8C060AC5283D00E05E803BB75079E1E9D29DA
---
{{<questions name="/content/nl/calculator.json" completed="" showNavigationButtons=true registerJavaScript="getItemPrice,botTotal,migrationTotal" locale="nl">}}
<script>
window.getItemPrice = getItemPrice = function (params) {
  var rowType = !!this.row
    ? this.row.getQuestionByColumnName('type')
    : null;

    var modeType = !!this.row
    ? this.row.getQuestionByColumnName('mode')
    : null;
  // if we can't find a question inside the cell (by row and column name) then return
  if (! rowType || ! modeType) 
    return 0;
  
  // get the selected item/choice
  var selectedType = rowType.selectedItem;

  if ( selectedType == null ) {
    // return 0 if a user did not select the item yet.
    return 0
  }

  var modeType = modeType.selectedItem;

  if ( modeType == null ) {
    // return 0 if a user did not select the item yet.
    return 0
  }

  switch ( selectedType.value ) {
    case "Trial":
        return 0;
    case "User":
        switch ( modeType.value ) {
            case "Attended":
                return 40;
                break;
            case "Unattended":
                return 190;
                break;
            case "Cloud":
                return 15;
            default:
                return "";
        }
        break;
    case "Flow":
        switch ( modeType.value ) {
            case "Attended":
                return "";
                break;
            case "Unattended":
                return (150 * 5) + (5 * 100);
                break;
             case "Cloud":
                return (5 * 100);
                break;
            default:
                return "";
        }
        break
    case "Extra Flow":
        switch ( modeType.value ) {
            case "Attended":
                return "";
                break;
            case "Unattended":
                return 150 + 100;
                break;
             case "Cloud":
                return 100;
                break;
        }
        break;
  }
};
window.botTotal = function(row) {
    if ( row == null || row.length == 0 || row[0] == null || row[0].percentage == null ) {
        return 0;
    }
    let bots =  window.currentSurvey.data['how-many-bots'] + 0;
    return (bots * (row[0].percentage / 100));
}
window.migrationTotal = function(row) {
     if ( row == null || row.length == 0 || row[0] == null || row[0].botsPerMonth == null ) {
      return 0;
    }
    let rowBots = botTotal(row);
    return Math.ceil((rowBots / row[0].botsPerMonth) * 20);
}
window.surveyChanged = function (sender, options) {
    window.currentSurvey = sender;
    var calculateChange = () => {
        let bots = sender.data['how-many-bots'] + 0;
        let percentAttended = sender.data['attended-percentage'] + 0;
        let percentUnattended = sender.data['unattended-percentage'] + 0;
        let attended = bots * ( percentAttended / 100);
        let unattended = bots * ( percentUnattended / 100);
        let items = [];
        if ( attended > 0 ) {
            items.push({service: 'U_RPA_A', quantity: attended})
        }
        if ( unattended > 0 ) {
            items.push({service: 'U_RPA_UA', quantity: unattended})
        }
        sender.setValue('items', items);
        calculatePlan()
    }
    var calculatePlan = () => {
        if ( sender.data['calc-migration-plan'] == false ) {
            return;
        }
        let bots = sender.data['how-many-bots'] + 0;
        let times = sender.data['migration-times']
        let attendedPercentage = sender.data['attended-percentage']
        let unattendedPercentage = sender.data['unattended-percentage']
        let groups = sender.data['migration-groups']
        if ( times == null || groups == null ) {
            return;
        }

        var groupData = {}
        for ( var i = 0; i < groups.length; i++ ) {
            groupData[groups[i].name] = {
                'name': groups[i].name,
                'months': []
            }
        }
        
        for ( var i = 0; i < times.length; i++ ) {
            if ( times[i].group == null || times[i].group.length == 0 ) {
                continue;
            }
            if ( typeof times[i].total === "undefined" ) {
                continue;
            }
            let group = groupData[times[i].group];
            let months = Math.ceil(times[i].total / 20);
           
            while ( months > group.months.length ) {
                group.months.push({
                    'name': group.name + ' ' + (group.months.length + 1),
                    'low': 0,
                    'medium': 0,
                    'high': 0,
                    'attended': 0,
                    'unattended': 0,
                })
            }

            for ( var month = 0; month < months; month++) {
                var botsMigrated = times[i].botsPerMonth
                if (month + 1 == months) {
                    if ( bots > times[i].botsPerMonth ) {
                        botsMigrated = Math.min(botsMigrated, bots - (month * times[i].botsPerMonth));
                    } else {
                        botsMigrated = bots;
                    }
                }
                switch ( times[i].complexity ) {
                    case "low":
                        group.months[month].low += botsMigrated;
                        break;
                    case "medium":
                        group.months[month].medium += botsMigrated;
                        break;
                    case "high":
                        group.months[month].high += botsMigrated;
                        break;
                }
                group.months[month].attended += Math.round(botsMigrated * (attendedPercentage / 100));
                group.months[month].unattended += Math.round(botsMigrated * (unattendedPercentage / 100));
            }
            
        }
        var items = [];
        for ( var i = 0; i < groups.length; i++ ) {
            var group = groupData[groups[i].name]
            for ( var month = 0; month < group.months.length; month++ ) {
                items.push(group.months[month]);
            }
        }
        sender.setValue('migration-plan', items);
    }
    switch ( options.name ) {
        case 'how-many-bots':
        case 'attended-percentage':
        case 'unattended-percentage':
            calculateChange();
            break;
        case 'migration-groups':
            var items = []
            if ( options.value != null ) {
                for ( var i = 0; i < options.value.length;i++ ) {
                    if ( typeof options.value[i].name === "string" && options.value[i].name.length > 0 ) {
                        items.push(options.value[i].name);
                    }
                }
            }
            let groups = sender.getQuestionByName('groups')
            if ( typeof groups !== "undefined") {
                groups.choices = items
            }
            break;
        case 'migration-times':
            calculatePlan();
            break;
        case 'sample-scenario':
            switch ( options.value ) {
                case 'migration-single-unattended':
                    sender.setValue('how-many-bots', 1);
                    sender.setValue('attended-percentage', 0);
                    sender.setValue('unattended-percentage', 100);
                    var groups1 = sender.getQuestionByName('groups')
                    if ( typeof groups1 !== "undefined") {
                        groups1.choices = ['Migration']
                    }
                    sender.clearValue('migration-groups')
                    sender.setValue('migration-groups',[
                        {name: 'Migration', description: "Migrate single bot"}
                    ])
                    sender.clearValue('migration-times')
                    sender.setValue('migration-times', [ 
                        {'complexity':'low', 'service':'U_RPA_UA', 'percentage': 100, group: 'Migration', 'botsPerMonth': 1 }
                    ]);
                    sender.clearValue('items')
                    sender.setValue('items',[{'type':'User', 'mode': 'Unattended', 'quantity':1}]);
                    break;
                case 'migration-200':
                    sender.setValue('how-many-bots', 200);
                    sender.setValue('attended-percentage', 90);
                    sender.setValue('unattended-percentage', 10);
                    sender.setValue('bots-per-month-ramp', 5);
                    sender.setValue('bots-per-month-factory', 20);
                    sender.clearValue('migration-groups')
                    var groups2 = sender.getQuestionByName('groups')
                    if ( typeof groups2 !== "undefined") {
                        groups2.choices = ['Ramp Up', 'Factory']
                    }
                    sender.setValue('migration-groups',[
                        {name: 'Ramp Up', description: "Setup migration patterns and engage business units"},
                        {name: 'Factory', description: "Wave deployment model of bots per month"},
                    ])
                    sender.clearValue('migration-times')
                    sender.setValue('migration-times', [
                        {'complexity':'low', 'percentage': 1, group: 'Ramp Up', botsPerMonth: 2 }, 
                        {'complexity':'low', 'percentage': 59,  group: 'Factory', botsPerMonth: 15 }, 
                        {'complexity':'medium', 'percentage': 30, group: 'Factory', botsPerMonth: 20 },
                        {'complexity':'high', 'percentage': 10, group: 'Factory', botsPerMonth: 2 }
                    ]),
                    sender.clearValue('items')
                    sender.setValue('items',[
                        {'type':'User', 'mode': 'Attended', 'quantity':180},
                        {'type':'User', 'mode': 'Unattended', 'quantity':20}
                    ]);
                    break;
            }
            break;
    }
}
</script>
{{</questions>}}
