# CalculatorOOPS
Create a fun calculator implementation.
1) Create ICalculator interface which has declarations of methods add, subtract, divide, multiply, nPr, nCr.
2) Make two implementations of the ICalculator interface : 
	a) TraditionalCalculator which defines all the methods as per real life.
	b) CrazyCalculator which does not peform the function's literal meaning. 
	    It should : 
		Add for Subtract and vice versa
		Divide for Multiply and vice versa
		nPr for nCr and vice versa
3) The user should be allowed to choose which implementation he wants to go for, during run time.
4) The menu to be displayed to the user should be stored in a file and fetched from there using file I/O operations.
5) All strings must be inside a KeyStore.
6) Make maximum use of encapsulation.
7) In Main function, the user is asked to choose for which implementation he wants to go for, then enter an equation of the form "aOperationB".
	eg: 8+9 
	    10-2
            5*6
	    90/3
            30p9
	    12c4
    Depending on the operation in the equation it should direct to the correct method and output the answer.
