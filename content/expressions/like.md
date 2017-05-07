+++
name = "LIKE"
date = "2016-11-23T19:36:30-06:00"
title = "like"

+++

#### Syntax
	<field_expr> [ NOT ] LIKE <like_mask>

#### Description
Determines whether or not a given character string matches a specified pattern. A pattern can include regular characters and wildcard characters. During pattern matching, regular characters must yield a case-insensitive match with the characters specified in the character string. Wildcard characters, however, can be matched with arbitrary fragments of the character string. Using wildcard characters makes the LIKE operator more flexible than using the = and != string comparison operators. _ (underscore) matches any single character, while % (percent) matches any string of zero or more characters.
