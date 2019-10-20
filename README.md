# Assignment 7

### Links

[Material](https://datsoftlyngby.github.io/soft2019fall/DM/week-41/info.html)

### Explanation 

As you may have noticed I really didn't work too hard on this. Regardless, I have _something_ to say. The `deposit` method is pretty boring, but since it only ensures that the amount is greater than 0. The `deposit` on the other hand may throw an exception, if the amount is greater than the balance, and also ensures that if that does happen, the balance remains unchanged. 

Since both methods require withdrawing requires the amount to be atleast the same as the balance, I created an invariant to guarantee that the balance **never** goes below 0(because of that also added a precondition for the constructor). In reality of course, you can have a negative balance, but I thought in this case it makes sense, since it cannot be done.
