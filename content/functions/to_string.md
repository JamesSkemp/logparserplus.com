+++
name = "TO_STRING"
syntax = "TO_STRING( argument <INTEGER | REAL> ) | ( timestamp <TIMESTAMP>, format <STRING> )"
description = "Converts a value of the REAL or INTEGER data type into a value of the STRING data type."
type = "conversion"
+++

#### Examples
- `TO_STRING(TO_LOCALTIME(TO_TIMESTAMP(date, time)), 'yyyy-MM-dd') AS [Day]`  
  Converts the date and time of a request to local time, and then outputs the day as a string (2010-03-22).
