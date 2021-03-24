import random

def main():
    number_of_people = int(input("how many people? "))
    number_of_experiments = int(input("how many experiments? "))
    birthdays = []
    number_of_duplicates = 0
    number_of_different = 0
    for i in range(number_of_experiments):
        for x in range(number_of_people):
            birthdays.append(random.randint(1,365))
            if (len(birthdays) != len(set(birthdays))):
                number_of_duplicates+= 1
                break
            elif (x == number_of_people-1):
                number_of_different+=1
        birthdays = []

    print(f"Duplicates: {number_of_duplicates}")
    print(f"No Duplicates: {number_of_different}")
    print(f"Percentage of duplicates: {(number_of_duplicates/number_of_experiments)*100}\n")
    repeat()

def repeat():
    repeat = input("Do you want to repeat the experiment? Y|N: ")
    if (repeat.upper() == 'Y'):
        main()
    else:
        return





if __name__ == "__main__":
    main()