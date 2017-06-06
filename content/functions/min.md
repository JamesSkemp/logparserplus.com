+++
name = "MIN"
syntax = "MIN( [ DISTINCT | ALL ] &lt;field_expr&gt; )"
description = "Returns the minimum value among all the values of the specified field-expression."
type = "aggregate"
related = ["MAX"]
+++

#### Examples
- `MIN(sc-bytes) AS [Minimum Bytes Sent]`  
  Returns the minimum number of bytes sent from the server to the client, across all requests.
