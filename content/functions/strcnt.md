+++
name = "STRCNT"
syntax = "STRCNT( string <STRING>, token <STRING> )"
description = "Returns the number of occurrences of a substring in a string."
type = "string manipulation"
+++

#### Examples
- `STRCNT(cs-uri-stem, '/') AS [Request Depth]`  
  Returns the depth of a requested file.
