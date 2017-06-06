+++
name = "SYSTEM_TIMESTAMP"
syntax = "SYSTEM_TIMESTAMP()"
description = "Returns the current system date and time in Universal Time Coordinates (UTC) time."
type = "system information"
related = ["SYSTEM_DATE", "SYSTEM_TIME"]
+++

#### Examples
- `TO_LOCALTIME(SYSTEM_TIMESTAMP) AS [CurrentLocalTime]`  
  Get the current date and time, converted to local time.
- `SUB(TO_LOCALTIME(SYSTEM_TIMESTAMP()), TIMESTAMP('0000-01-01 00:03', 'yyyy-MM-dd HH:mm'))`  
  Get the local time 3 minutes ago.
