const ics = require('ics')
const { writeFileSync } = require('fs')
var moment = require('moment-timezone');
const fs = require('fs');
var path = require('path');
// or, in ESM: import * as ics from 'ics'

const eventConfig = require('./event.json');
const config = require('./config.json');

var seriesStart = moment.tz(eventConfig.start, eventConfig.timezone);

const eventTemplate = {
  start: seriesStart.utc().format("yyyy-M-D-H-m").split('-').map(Number),
  startInputType: 'utc',
  duration: { hours: 1, minutes: 0 }
}

ics.createEvent(Object.assign({},eventTemplate,config), (error, value) => {
  if (error) {
    console.log(error)
    return
  }

  var invite = path.join(__dirname,"..", "..", "..", "officehours.ics")

  writeFileSync(invite, value)
})