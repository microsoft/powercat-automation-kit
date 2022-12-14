---
title: "Kalkulator"
description: "Automation Kit - Kalkulator"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: A395D9B90CE714462F5170710C6C39AA2873234A
---


{{<questions name="/content/pl/calculator.json" completed="" showNavigationButtons=true registerJavaScript="getItemPrice,getNumber" locale="pl">}}
<script>
window.getNumber = function (params) {
    return parseInt(window.currentSurvey.data[params[0]])
}
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

window.surveyChanged = function (sender, options) {
    window.currentSurvey = sender;

    var calculateChange = () => {
        let bots = sender.data['how-many-automation-projects'] + 0;
        let percentAttended = sender.data['attended-percentage'] + 0;
        let percentUnattended = sender.data['unattended-percentage'] + 0;
        let attended = Math.round(bots * ( percentAttended / 100));
        let unattended = Math.round(bots * ( percentUnattended / 100));
        let items = [];
        if ( attended > 0 ) {
            items.push({service: 'U_RPA_A', quantity: attended})
        }
        if ( unattended > 0 ) {
            items.push({service: 'U_RPA_UA', quantity: unattended})
        }
        sender.data["items"] = items
        calculatePlan()
    }

    var calculatePlan = () => {
        if ( sender.data['calc-migration-plan'] == false ) {
            return;
        }
        let times = sender.data['migration-times']
        let attendedPercentage = sender.data['attended-percentage']
        let unattendedPercentage = sender.data['unattended-percentage']
        let groups = sender.data['migration-groups']
        if ( times == null || times.length == 0 || groups == null ) {
            return;
        }

        var groupData = {}
        for ( var i = 0; i < groups.length; i++ ) {
            let months = times.reduce((accumlator, currentValue) => { 
                return Math.max(accumlator, ( groups[i].name == currentValue.group ) ? Math.ceil(currentValue.projects / currentValue.projectsPerMonth) : 0)
            }, 0)
            groupData[groups[i].name] = {
                'name': groups[i].name,
                'months': Array.apply(null, Array(months)).map(function(element, index) { return {
                    name: groups[i].name + " " + (index + 1),
                    low:0,
                    medium: 0,
                    high: 0,
                    attended: 0,
                    unattended: 0
                } }),
                'projects': times.reduce((accumlator, currentValue) => { 
                    return accumlator + (( groups[i].name == currentValue.group ) ? currentValue.projects : 0)
                }, 0),
                'low': times.reduce((accumlator, currentValue) => { 
                    return accumlator + (( groups[i].name == currentValue.group && currentValue.complexity == "low" ) ? currentValue.projects : 0)
                }, 0),
                'medium': times.reduce((accumlator, currentValue) => { 
                    return accumlator + (( groups[i].name == currentValue.group && currentValue.complexity == "medium" ) ? currentValue.projects : 0)
                }, 0),
                'high': times.reduce((accumlator, currentValue) => { 
                    return accumlator + (( groups[i].name == currentValue.group && currentValue.complexity == "high" ) ? currentValue.projects : 0)
                }, 0)
            }
            var remaining = {
                low: groupData[groups[i].name].low,
                medium: groupData[groups[i].name].medium,
                high: groupData[groups[i].name].high,
            }
            for ( var t = 0; t < times.length; t++ ) {
                if ( times[t].group == groups[i].name ) {
                    let groupTimeMonths = Math.ceil((times[t].projects / times[t].projectsPerMonth));
                    for ( var m = 0; m < groupTimeMonths; m++) {
                        let value = remaining[times[t].complexity];
                        let projects = Math.min(value, times[t].projectsPerMonth);
                        groupData[groups[i].name].months[m][times[t].complexity] = Math.max(projects,0)
                        value -= projects;
                        remaining[times[t].complexity] = value
                    }
                }
            }
            groupData[groups[i].name].months.map((month) => {
                let total = month.low + month.medium + month.high;
                month.attended = Math.round(total * ( attendedPercentage / 100));
                month.unattended = Math.round(total * ( unattendedPercentage / 100));
            })
        }

        var items = [];
        groups.map((group) => {
            let months = (groupData[group.name]).months;
            months.map((item) => items.push(item))
        })
        sender.setValue("migration-plan", items);
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
                    sender.setValue('how-many-automation-projects', 1);
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
                        {'complexity':'low', 'service':'U_RPA_UA', 'percentage': 100, group: 'Migration', 'projectsPerMonth': 1 }
                    ]);
                    sender.clearValue('items')
                    sender.setValue('items',[{'type':'User', 'mode': 'Unattended', 'quantity':1}]);
                    break;
                case 'migration-200':
                    sender.setValue('how-many-automation-projects', 200);
                    sender.setValue('attended-percentage', 90);
                    sender.setValue('unattended-percentage', 10);
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
                        {'complexity':'low', 'percentage': 1, group: 'Ramp Up', projectsPerMonth: 2 }, 
                        {'complexity':'low', 'percentage': 59,  group: 'Factory', projectsPerMonth: 15 }, 
                        {'complexity':'medium', 'percentage': 30, group: 'Factory', projectsPerMonth: 20 },
                        {'complexity':'high', 'percentage': 10, group: 'Factory', projectsPerMonth: 2 }
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
