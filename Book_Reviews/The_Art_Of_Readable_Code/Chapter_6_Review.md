# The Art of Readable Code
### Chapter 6: Making Comments Precise and Compact
### Summary

This chapter puts forth the importance of writing comments that are precise and compact in the pursuit of maintaining better information to space ratio.

It provides various strategies along with their relevant examples to achieve this goal:

#### 1. Keeping comments compact by avoiding unnecessary wordiness.
- Original 

    ```csharp
    // The int is the CategoryType.
    // The first float in the inner pair is the 'score',
    // the second is the 'weight'.
    typedef hash_map<int, pair<float, float> > ScoreMap;
    ```
- Compact
    ```csharp
    // CategoryType -> (score, weight)
    typedef hash_map<int, pair<float, float> > ScoreMap;
    ```
#### 2. Avoiding ambiguous pronouns
- Original
    ```csharp
    // Insert the data into the cache, but check if it's too big first.
    ```
    > Here, "it" can specify either data or cache.

- Improved
    ```csharp
    // Insert the data into the cache, but check if the data is too big first.
    ```
#### 3. Polishing long sentences to make them more concise and direct.
- Original

    ```csharp
    // Depending on whether we've already crawled this URL before, give it a different priority.
    ```
- Improved
    ```csharp
    // Give higher priority to URLs we've never crawled before.
    ```
#### 4. Describing function behaviour precisely, considering various scenarios.
- Original

    ```csharp
    // Return the number of lines in this file.
    int CountLines(string filename) { ... }
    ```
- Improved
    ```csharp
    // Count how many newline bytes ('\n') are in the file.
    int CountLines(string filename) { ... }
    ```
    > Specifies the logic for counting lines in the file.

#### 5. Provide input/output examples to show handling of corner cases
- Original
    ```csharp
    // Example: Strip("ab", "a") returns "b"
    String Strip(String src, String chars) { ... }
    ```
    > Too simple of a test case.
    
- Improved
    ```csharp
    // Example: Strip("abba/a/ba", "ab") returns "/a/"
    String Strip(String src, String chars) { ... }
    ```
    > "Shows off" the full functionality of Strip().
    
#### 6. Stating the intent of the code in a suitable context
- Original
    ```cpp
    // Iterate through the list in reverse order
    for (list<Product>::reverse_iterator it = products.rbegin(); ... )
    ```
    > Simply states what the code does in literal terms.
    
- Improved
    ```cpp
    // Display each price, from highest to lowest
    for (list<Product>::reverse_iterator it = products.rbegin(); ... )
    ```
    > Explains what the program is doing at a higher level.

#### 7. Inserting "Named function parameter" comments to clarify function calls.
- Original

    ```cpp
    Connect(10, false);
    ```
- Improved

    ```cpp
    Connect(/* timeout_ms = */ 10, /* use_encryption = */ false);
    ```

#### 8. Using information dense words for common programming scenarios.
- Original

    ```cpp
    // Remove excess whitespace from the street address, and do lots of other cleanup
    // like turn "Avenue" into "Ave."
    ```
- Improved
    ```cpp
    // Canonicalize the street address (remove extra spaces, "Avenue" -> "Ave.")
    ```
    > Similarly to "Canonicalize", other words and phrases such as "Heuristic", "Brute force" and "Naive solution" are recommended for use in their respective programming situations .

## Authors

*Joel Lalrinnunga Ralte*

*Nachiappan R*





