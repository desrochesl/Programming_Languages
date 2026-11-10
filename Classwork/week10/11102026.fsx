"""1. What is Scanner (in compiler?) what are the inputs and outputs

Scanners job is to break source code into tokens. 

Input: Raw source code
Output: Stream of tokens"""


"""2. a) The cat chased a dog - is this valid according to the grammar?

Yes. This sentence valid according to the grammar"""

"""3. The dog saw the cat - Build the abstract syntax tree:

S -> NP VP

NP -> det N

det -> The

N -> Dog | Cat

V -> saw


            N - cat
        NP
            Det - the
    VP

        V - saw

s       

        N - dog
    NP
        Det - The
"""


"""4. Build AST for: 4 * 2 + 6



            EXPR    TERM    FACTOR  NUMBER  - 6
TERM + EXPR 
                    TERM    FACTOR  - NUMBER - 4
            TERM    *
                    FACTOR
                            FACTOR  - NUMBER - 2

"""
