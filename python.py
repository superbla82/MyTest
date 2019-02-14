#!/usr/bin/env python3
# -*- coding: utf-8 -*-

import random

def WOOP():
    RPS = ("Rock", "Paper", "Scissors")
    
    p1wins = 0
    p2wins = 0
    
    userinput = int(input("How many rounds? "))
    
    for i in range(0, userinput):
        p1 = random.choice(RPS)
        p2 = random.choice(RPS)
        print("P1 got: ", p1)
        print("P2 got: ", p2)
        if p1 == p2:
            print("Draw!")
        elif p1 == RPS[0] and p2 == RPS[1]:
            print("Player2 won!")
            p2wins += 1
        elif p1 == RPS[1] and p2 == RPS[2]:
            print("Player2 won!")
            p2wins += 1
        elif p1 == RPS[2] and p2 == RPS[0]:
            print("Player2 won!")
            p2wins += 1
        else:
            print("Player1 won!")
            p1wins += 1
        i += 1
        
    if p1wins < p2wins:
        print("Winner is P2")
    if p2wins < p1wins:
        print("Winner is P1")
        
    print("Press any key to play again")
    input()    
    WOOP()

WOOP()
