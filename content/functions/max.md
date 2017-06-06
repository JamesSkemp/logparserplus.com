+++
name = "MAX"
syntax = "MAX( [ DISTINCT | ALL ] <field_expr> )"
description = "Returns the maximum value among all the values of the specified field-expression."
type = "aggregate"
related = ["MIN"]
+++

#### Examples
- `MAX(sc-bytes) AS [Maximum Bytes Sent]`  
  Returns the maximum number of bytes sent from the server to the client, across all requests.
