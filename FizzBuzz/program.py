# this is where your program's methods are define
def printNumberRange(startNumber, endNumber):
    # start your code here
    for index in range(startNumber, endNumber+1):
        if index%15==0:
            print('fizzbuzz', end=' ')
        elif index%5==0:
            print('buzz', end=' ')
        elif index%3==0:
            print('fizz', end=' ')
        else:
            print(index, end=' ')
    input("Program completed. Press any key to exit")

# this is where the program will start!
print("Welcome to FizzBuzz!")

x = 1
y = 20

printNumberRange(x, y)

