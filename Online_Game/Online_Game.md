# Online Game
John likes to play an online game. In the game, a 15 minutes long round starts each and every HH:00, HH:15, HH:30, and HH:45, where HH is the hour ranging between 00 and 23. John uses a 24-hour clock, so the earliest time is 00:00 and the latest is 23:59.

Assume John starts to play at time A and stops playing at time B, what is the maximum number of full game rounds that John could have played?

Write a function:

`class Solution { public int solution(string A, string B) }; `

that given the strings A and B (in HH:MM format) returns the maximum number of full game rounds that John coukld have played within the given period of time.

**Exampels:**

1. If `A = "12:01"` and `B = "12:44"` the function shall return 1.
2. If `A = "20:00"` and `B = "06:00"` the function shall return 40.
3. If `A = "00:00"` and `B = "23:59"` the function shall return 95. John ended 1 minute before full round (23:45 - 00:00).
4. If `A = "12:03"` and `B = "12:03"` the function shall return 0. John cannot play any round during an empty period of time.

**Assume that:**
* strings A and B represent valid times in a HH:MM format.