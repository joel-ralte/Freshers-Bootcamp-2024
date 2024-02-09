# Shopping Cart Checkout Test Specifications

#### Test Case 1: Empty Input
- Given: ""
- Expected Price: 0

#### Test Case 2: One Item
- Given: "A"
- Expected Price: 50

#### Test Case 3: Two Items with Offer
- Given: "AA"
- Expected Price: 100

#### Test Case 4: Two Items with no Offer
- Given: "AB"
- Expected Price: 80

#### Test Case 5: Three Items with Offer 
- Given: "AAA"
- Expected Price: 130

#### Test Case 6: Three Items with no Offer
- Given: "ABC"
- Expected Price: 100

#### Test Case 7: Three Items including an Offer among Items
- Given: "BAB"
- Expected Price: 95

#### Test Case 8: Four Items with no Offer
- Given: "CDBA"
- Expected Price: 115

#### Test Case 9: Multiple Items including Multiple Offers among Items
- Given: "AAABBB"
- Expected Price: 205
