+++
name = "TO_TIMESTAMP"
syntax = "TO_TIMESTAMP( dateTime1 <TIMESTAMP>, dateTime2 <TIMESTAMP> ) | ( string <STRING>, format <STRING> ) ( seconds <INTEGER | REAL> )"
description = "Parses a string representing a timestamp and returns a value of the TIMESTAMP data type."
type = "conversion"
+++

#### Examples
- `TO_TIMESTAMP(date, time)`  
  Converts the date and time of a request into a timestamp, for use with other functions.
- `TO_TIMESTAMP('2009-02-06', 'yyyy-MM-dd')`  
  Creates a timestamp of the date February 6, 2009.
- `TO_TIMESTAMP('2010-02-15 10:15', 'yyyy-MM-dd HH:mm')`  
  Creates a timestamp of February 25, 2010, at 10:15 in the morning.
- `TO_TIMESTAMP('24 Jun 2011 13:22:21', 'dd MMM yyyy HH:mm:ss')`  
  Creates a timestamp of a date/time in 'short' format.

#### See also
See also [Microsoft Log Parser timestamp formats](http://words.strivinglife.com/post/Microsoft-Log-Parser-timestamp-formats/) by James Skemp. There seems to be no difference between using `TO_TIMESTAMP()` and just `TIMESTAMP()`.
