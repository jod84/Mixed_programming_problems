# Passing Cars
The traffic and speed cameras in a street is described by a string S.
S only contains the characters '<', '>', and '.', where:

* `<` is a car heading to the left.
* `>` is a car heading to the right.
* `.` is a speed camera.  

Find the total sum of each time a car pass by a speed camera. Note, a car
will only pass cameras that are ahead of it.

Write a function:

`class Solution { public int solution(string S) }; `

that for string S of length **N** returns the total sum of all
speed camera drive-by that all cars have done.

**Exampels:**

1. If `S = "...<..."` the function shall return 3, since the car going left has 3 speed cameras to the left of it.
2. If `S = "...<>..."` shall return 2 * 3 = 6.
3. If `S = ".<.>.<.>>.."` shall return 1 + 3 + 4 + 2 + 2 = 12 

**Assume that:**
* **N** is an integer within the range [1,100];
* That string S only consists of the characters `<`, `>`, and `.`.