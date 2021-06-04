# pos-terminal-exercise
Exercise from my wifes bootcamp that I decided to do for fun.

# Requirements
1. Your solution must include some kind of a product class with a name, category, description,
			 and price for each item.

2. 12 items minimum; they must be stored in a text file your program reads in. 
	
3. Present a menu to the user and let them choose an item (by number or letter).
	
4. Allow the user to choose a quantity for the item ordered.

5. Give the user a line total (item price quantity).

6. Either through a menu or a separate question, allow them to re-display the menu and to complete the purchase.

7. Give the subtotal, sales tax, and grand total.

8. Use an Abstract Class or an Interface for the various payment methods. 
	- Include a separate class for each payment method that inherits from that parent class.

9. Ask for the payment type--cash, credit, or check.
	a. For cash, ask the amount tendered and provide change.
	b. For check, get the check number.
	c. For credit, get the credit card  number, expiration, and CVV.

10. At the end, display a receipt with all items ordered, subtotal, grand total, and appropriate payment info.

11. Return to the original menu for a new order. (Hint you’ll want an array or List to keep track of what’s been
	ordered!)

12. Optional enhancements (Moderate) Include an option to add to the product list, which then outputs to the
	product file.