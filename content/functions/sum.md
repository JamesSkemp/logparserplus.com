+++
name = "SUM"
syntax = "SUM( [ DISTINCT | ALL ] <field_expr> )"
description = "Returns the sum of all the values, or only the DISTINCT values, of the specified field-expression."
type = "aggregate"
+++

#### Examples
- `SUM(sc-bytes) AS [Total Bytes Sent]`  
  Returns the total number of bytes sent from the server to the client.
