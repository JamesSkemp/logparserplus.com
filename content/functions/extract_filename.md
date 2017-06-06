+++
name = "EXTRACT_FILENAME"
syntax = "EXTRACT_FILENAME( filepath <STRING> )"
description = "Returns the filename portion of a file path."
type = "string manipulation"
related = ["EXTRACT_EXTENSION", "EXTRACT_PATH", "EXTRACT_PREFIX", "EXTRACT_SUFFIX", "EXTRACT_TOKEN", "EXTRACT_VALUE"]
+++

#### Examples
- `EXTRACT_FILENAME(cs-uri-stem) AS [File Requested]`  
  Extracts the file name for requests.
