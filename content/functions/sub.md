+++
name = "SUB"
syntax = "SUB( minuend &lt;any type&gt;, subtrahend &lt;any type&gt; )"
description = "Calculates the difference of two values."
type = "arithmetical"
related = ["ADD", "DIV", "MUL"]
+++

#### Examples
- `TO_DATE(SUB(TO_LOCALTIME(SYSTEM_TIMESTAMP()), TIMESTAMP('0000-01-08', 'yyyy-MM-dd')))`  
  Gets the date seven days ago, based on the current local date/time.
