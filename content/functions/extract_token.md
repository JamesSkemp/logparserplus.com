+++
name = "EXTRACT_TOKEN"
syntax = "EXTRACT_TOKEN( argument &lt;STRING&gt;, index &lt;INTEGER&gt; [ , separator &lt;STRING&gt; ] )"
description = "Splits the string into substrings at each point where the separator occurs, and returns the substring with the specified index."
type = "string manipulation"
related = ["EXTRACT_EXTENSION", "EXTRACT_FILENAME", "EXTRACT_PATH", "EXTRACT_PREFIX", "EXTRACT_SUFFIX", "EXTRACT_VALUE"]
+++

#### Examples
- `EXTRACT_TOKEN(cs(Referer), 2, '/') AS [Referring Domain]`  
  Returns full domain of the site referring traffic to this resource.
