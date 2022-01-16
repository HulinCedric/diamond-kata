Feature: Print diamond

Print a diamond starting with 'A' with the supplied letter at the widest point.

**Kata description**: [Recycling tests in TDD](http://claysnow.co.uk/recycling-tests-in-tdd)
**Feature description**: [Diamond recycling (and painting yourself into a corner)](http://claysnow.co.uk/diamond-recycling-and-painting-yourself-into-a-corner)

    Example: Print diamond A
        Given the letter 'A'
        When print a diamond
        Then diamond prints
        """
        A
        """

    Example: Print diamond B
        Given the letter 'B'
        When print a diamond
        Then diamond prints
        """
         A 
        B B
         A 
        """

    Example: Print diamond C
        Given the letter 'C'
        When print a diamond
        Then diamond prints
        """
          A  
         B B 
        C   C
         B B 
          A  
        """

    Example: Print diamond D
        Given the letter 'D'
        When print a diamond
        Then diamond prints
        """
           A   
          B B  
         C   C 
        D     D
         C   C 
          B B  
           A   
        """

    Example: Print diamond E
        Given the letter 'E'
        When print a diamond
        Then diamond prints
        """
            A    
           B B   
          C   C  
         D     D 
        E       E
         D     D 
          C   C  
           B B   
            A    
        """