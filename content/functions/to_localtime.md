+++
name = "TO_LOCALTIME"
syntax = "TO_LOCALTIME( timestamp <TIMESTAMP> )"
description = "Converts a timestamp from Universal Time Coordinates (UTC) time into local time."
type = "conversion"
related = ["TO_UTCTIME"]
+++

#### Examples
- `TO_LOCALTIME(TO_TIMESTAMP(date, time)) AS [LocalTime]`  
  Create a timestamp from the date and time of a request and convert it to local time.
