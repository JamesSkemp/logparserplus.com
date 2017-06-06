+++
name = "GROUPING"
syntax = "GROUPING( <field_expr> )"
description = "Returns a value of 1 when the row is added by the ROLLUP operator of the GROUP BY clause, or 0 when the row is not the result of ROLLUP. GROUPING is used to distinguish the NULL values returned by ROLLUP from standard NULL values. The NULL returned as the result of a ROLLUP operation is a special use of NULL. It acts as a value placeholder in the result set and means "all"."
type = "aggregate"
+++

