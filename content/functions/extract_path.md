+++
name = "EXTRACT_PATH"
syntax = "EXTRACT_PATH( filepath <STRING> )"
description = "Returns the directory path portion of a file path."
type = "string manipulation"
related = ["EXTRACT_EXTENSION", "EXTRACT_FILENAME", "EXTRACT_PREFIX", "EXTRACT_SUFFIX", "EXTRACT_TOKEN", "EXTRACT_VALUE"]
+++

#### Examples
- `EXTRACT_PATH(cs-uri-stem) AS [Path Requested]`  
  Extracts the path of a request. The trailing slash (/) is removed.
