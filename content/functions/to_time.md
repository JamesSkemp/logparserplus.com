+++
name = "TO_TIME"
syntax = "TO_TIME( timestamp <TIMESTAMP> )"
description = "Converts a full timestamp into a time-only timestamp."
type = "conversion"
related = ["TO_LOCALTIME", "TO_DATE"]
+++

#### Examples
- `TO_TIME(TO_LOCALTIME(QUANTIZE(TO_TIMESTAMP(date, time), 3600))) AS [Hour]`  
  Create a timestamp from the date and time of a request, drops the minutes from the time, converts it to local time, and pulls just the time.
