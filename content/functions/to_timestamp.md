+++
name = "TO_TIMESTAMP"
syntax = "TO_TIMESTAMP( dateTime1 &lt;TIMESTAMP&gt;, dateTime2 &lt;TIMESTAMP&gt; ) | ( string &lt;STRING&gt;, format &lt;STRING&gt; ) ( seconds &lt;INTEGER | REAL&gt; )"
description = "Parses a string representing a timestamp and returns a value of the TIMESTAMP data type. See also <a href="http://strivinglife.com/words/post/Microsoft-Log-Parser-timestamp-formats.aspx">Microsoft Log Parser timestamp formats</a> by James Skemp. There seems to be no difference between using TO_TIMESTAMP() and just TIMESTAMP()."
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
