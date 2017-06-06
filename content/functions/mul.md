+++
name = "MUL"
syntax = "MUL( multiplicand <INTEGER | REAL>, multiplier <INTEGER | REAL> )"
description = "Calculates the product of two values."
type = "arithmetical"
related = ["DIV", "ADD", "SUB"]
+++

#### Examples
- `MUL(PROPCOUNT(*), 100)`  
  When used with another field and a simple GROUP BY, returns the percentage of requests by that field. See example query <a href="http://logparserplus.com/Examples/Queries.aspx#query_12">HTTP status codes and percentage of total</a>.
