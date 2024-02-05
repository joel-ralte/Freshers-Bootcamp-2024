# TDD Kata 1
## String Adder Function
A function that takes a string input to add numbers.
### Test Specification
Format: Given("") - When(=>) - Then(Expected Output)
- "" => 0
- "0" => 0
-  "1" => 1
-  "1,2" => 3
-  "12,34"=> 46
-  "x, y" => (<=2^32-1)
-  "1\n2,3" => 6
-  “//;\n1;2” => 3
-  "-1" => Exception(“negatives not allowed”, "-1")
-  "-1,2" => Exception(“negatives not allowed”, "-1")
-  "-1,-2" => Exception(“negatives not allowed”, "-1,-2")
-  "1001,1" => 1
-  "2,2000" => 2
-  “//[;;;]\n1;;;2;;;3” => 6
-  “//[;][%]\n1;2%3” => 6
-  “//[;,][%,]\n1;,2%,3” => 6
