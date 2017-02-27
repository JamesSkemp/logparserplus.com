+++
name = "IN"
date = "2016-11-23T19:36:23-06:00"
title = "in"

+++

## Syntax
	<field_expr> [ NOT ] IN ( <value_rows> ) | ( <field_expr_list> ) [ NOT ] IN ( <value_rows> )

## Description
The IN and NOT IN operators determine whether or not a given field-expression or list of field-expressions matches any element in a list of values.

## Examples
- `EXTRACT_EXTENSION(cs-uri-stem) NOT IN ('jpg';'png';'gif';'ico')`
When used in a WHERE clause, excludes requests for common image formats.
- See [Removing potential bots from query results][article-5] for an example using a nested query.

[article-5]: /Article/5
