# coolOrange_CandidateChallenge

## Instructions
- Restore Nuget-Packages
- Press F5
- Run Tests for PalindromeCkecker and Task via Test Explorer

## Array
### 1. FindMaxValue
- Skip elements to position1
- Take range of elements to choose maximum value from
- Create array from IEnumerable
- Return maximum value

### 2. FindMinPosition
- Create list from array
- Find position of minimum value as in FindMaxValue

### 3. Swap
- Save element of position1 in the array to variable
- Assign element of position2 to position1
-Assign saved variable to position 2

### 4. ShiftLeftByOne
- Save subarray and shift everything one to the left
- Replace subarray in original array with newly created shifted array

### 5. CreateRandomArray
- Create new array
- Iterate over it's size and assign random values between minValue and maxValue using the Random class

### 6. CreateRandomMatrix
- Iterate over rows and columns and generating a random value between minValue and maxValue for each iteration using the Random class

### 7. CopyArray
- Create new array
- Create two dimensional array containig the orignal array twice

### 8. FindInSortedArray
- Find position of number in sorted array using binary search algorithm and return -1 if array does not contain number

## Palindrome Checker
### IsPalindrome Method
- Method that checks whether a given string begins and ends with the same character recursively and passing on a substring without the first and last character until ther is only one or none character left in case the first and last characters are always the same

## Object Oriented Programming
### 1. Task
- Created Class Task and interfaces IPriority and IComplexity
- IPriority contains methods SetPriority and GetPriority
- IComplexity contains methods SetComplexity and GetComplexity
- Implement IPriority. IComplexity, IComparable and their methods in Task
- Create constructor and passing a name
-Create properties for Name, Priority and Complexity

### 2. TaskDriver
- Create Class TaskDriver with main method
- Create three tasks: doingHomework, eatingLunch, programming and passing them needed values
- Compare all tasks and sort by imprtance

### 3. TaskTest
- Tests for CompareTo Method passing priority, complexity and expected result. Checks if result and expected result are equal.
- Tests for GetComplexity passing complexity. Checks if result and complexity are aqual and if result2 and complexity are not equal.
-  Tests for GetPriority passing priority. Checks if priority and result are equal and if priority and result2 are not equal.
- Tests for SetComplexity passing complexity. Checks if result is not null and if result and complexity are equal.
- Tests for SetPriority passing priority and expected result. Checks if result is not null and if result is equal to expected.