+++
name = "BETWEEN"
date = "2016-11-23T19:36:19-06:00"
title = "between"

+++

#### Syntax
	<field_expr> [ NOT ] BETWEEN <field_expr> AND <field_expr>

#### Description
The BETWEEN operator determines if a given field-expression belongs to a specified interval.

#### Examples
- `sc-status BETWEEN 400 AND 499`  
 Returns requests with a status code from 400 to 499, inclusive.
