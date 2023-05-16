# Message Notification
From a given `message`, prepare a notification to be displayed on a small display. The `message` is made of words seperated by single spaces. The small display limitates the notification to `K` characters. If the `message` is too long to be fully displayed, the `message` shall be truncated so that the new length is less or equal to `K`. The truncation shall obey the following constrains:

* The notification shall be as long as possible
* Only whole words can be cropped.
* If the `message` is truncated, it must end with "...". The three dots shall be separated from the last word with a single space.
* The notification may not be longer than `K` characters.
* If all words have to be cropped, the notification shall only be "...".

For example, if the `message` _= "And now here is my presentation"_ and `K` = _15_, the correct notification is _"And now ..."_. Note that:

* The notification "_And ..._" is incorrect because the notification is not as long as possible.
* The notification "_And now her ..._" is incorrect since a word in the original message (here) has been cropped.
* The notification "_And now ..._ " is incorrect since it ends with a space.
* The notification "_And now here..._" is incorrect because there is no space separating the dots and the last word.
* The notification "_And now here ..._" is incorrect since the length of the notification exceeds the `K` character limit.

Write a function:

```c#
class Solution { public string solution(string message, int K };
```

that given a **string** `message` and an **int** `K`, returns a string that obeys the above listed notification constraints.

**Exampels:**

1. For `message` = "_And now here is my presentation_" and `K` _= 15_, the function shall return "_And now ..._".
2. For `message` = "_There is an alligator with 80 teeth_" and `K` = _15_, the function shall return "_There is an ..._".
3. For `message` = "_Super nova_" and `K` = _4_, the function shall return "_..._".
4. For `message` = "_My big fat cat_" and `K` = _16_, the function shall return "_My big fat cat_".

**Assume that:**
* `K` is an integer within the range [3:500].
* The length of the **string** `message`is within the range [1:500]