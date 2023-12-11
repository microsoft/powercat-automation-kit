const ics = require('ics')
const { writeFileSync } = require('fs')
var moment = require('moment-timezone');
// or, in ESM: import * as ics from 'ics'

var pacific    = moment.tz("2023-12-12 07:00:00", "America/Los_Angeles");

const event = {
  start: pacific.utc().format("yyyy-M-D-H-m").split('-').map(Number),
  startInputType: 'utc',
  duration: { hours: 1, minutes: 0 },
  title: 'Automation Kit - Office Hours',
  description: 'https://aka.ms/AutomationKit/OfficeHours/Join\n\nThis meeting is a regular open forum for customers and partners to learn and ask questions about the Automation Kit for Power Platform. Come prepared to ask questions about existing features, learn how something works and new features you\'d like to see. \nPlease note:\n1. This session will be attended by multiple customers and partners and will be recorded.\n2. By attending this session, you consent to the recording being used for public recordings on YouTube. If you do not wish to be recorded, please let us know before the session starts.\n3. Please state any questions with the appropriate level of detail for this broader audience.\n4. While sections of this may cover introduction or overview session you can leverage our learning content https://aka.ms/approvals-kit and https://aka.ms/approvals-kit/learn to get started.',
  url: 'https://aka.ms/AutomationKit/OfficeHours/Join',
  busyStatus: 'BUSY',
  organizer: { name: 'Grant Archibald', dir: 'https://linkedin.com/in/grantarchibald' },
  recurrenceRule: 'FREQ=MONTHLY;INTERVAL=1;BYDAY=TU;BYSETPOS=2',
}

ics.createEvent(event, (error, value) => {
  if (error) {
    console.log(error)
    return
  }

  writeFileSync(`${__dirname}/../../officehours.ics`, value)
})