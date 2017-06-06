+++
name = "QUANTIZE"
syntax = "QUANTIZE( argument &lt;INTEGER | REAL | TIMESTAMP&gt;, quantization &lt;INTEGER | REAL&gt; )"
description = "Truncates a value to the nearest multiple of another value."
type = "arithmetical"
+++

#### Examples
- `QUANTIZE(TO_TIMESTAMP(date, time), 3600)`  
  Returns date/times to the hour. (In other words, drops the minutes.)
