+++
name = "EXTRACT_EXTENSION"
syntax = "EXTRACT_EXTENSION( filepath <STRING> )"
description = "Returns the file extension portion of a file path."
type = "string manipulation"
related = ["EXTRACT_FILENAME", "EXTRACT_PATH", "EXTRACT_PREFIX", "EXTRACT_SUFFIX", "EXTRACT_TOKEN", "EXTRACT_VALUE"]
+++

#### Examples
- `EXTRACT_EXTENSION(cs-uri-stem) AS [File Extension]`  
  Extracts the file extension for requests. Returns nothing for those without an extension.
- `EXTRACT_EXTENSION(cs-uri-stem) NOT IN ('jpg';'png';'gif';'ico')`  
  When used in a WHERE clause, excludes requests for common image formats.
