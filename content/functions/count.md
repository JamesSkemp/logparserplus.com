+++
name = "COUNT"
syntax = "COUNT( [ DISTINCT | ALL ] * ) | ( [ DISTINCT | ALL ] &lt;field_expr_list&gt; )"
description = "Returns the number of items in a group."
type = "aggregate"
+++

#### Examples
- `COUNT(DISTINCT cs-uri-stem) AS [Distinct Requests]`  
  Returns a count of how many distinct files were requested.
