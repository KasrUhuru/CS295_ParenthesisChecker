# CS295_ParenthesisChecker

This exercise was very difficult for me to conceptualize. Iterating from left to right on a string and then translating that to a Last In First Out data structure was not quite intuitive.
I started with an edge case to get the ball rolling. It was an arbitary decision to decide that an empty string is balanced, and I argue that a lack of parentheses (or an absence of matter period) is equivalent to balance.

The next edge case to tackle was a string with no parentheses, or non-parenthesis characters. It mystifies me that I can't use the "!=" operand to compare characters, as this feels like an easy evaluation, but I can dismiss this requirement by focusing on the relationship between () [] and {} and returning FALSE for any non-parenthetical input.

The most useful thing to do with my stack is to use it, and the easy part is to Push ( [ and { parentheses into the stack, since the evaluation of TRUE really starts with matching correctly paired parentheses.

I initially implemented a Peek() function, but that bogs down the code since matching character C to the Last In element also entails using Pop() to discard a matched parenthesis. It's redundant and adds no value, so efficiency was lost with no benefit. Peek() is no longer in the final version.

Nesting my if/else conditions feels very clunky here, and I think the majority of my time/processing cost is going to be in this latter half of the code. If a ( [ or { doesn't match to its twin, I return FALSE. That simple distinction is a powerful tool that rounds out this program. This also addresses balanced but improper parenthesis strings such as [(]), which looks paired but doesn't parse in any context I can think of.

I'm thinking about adapting this code to discard non-parenthesis characters with a simple line that ignores them. Actually, it's extremely simple to do that. I just need to look up the proper keyword to continue the foreach loop. Update: it is the keyword CONTINUE. Go figure.
