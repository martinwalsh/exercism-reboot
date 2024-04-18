# These variables are initialized on the command line (using '-v'):
# - num

BEGIN {
    if (num % 3 == 0) r = r "Pling";
    if (num % 5 == 0) r = r "Plang";
    if (num % 7 == 0) r = r "Plong";
    print (r ? r : num)
}
