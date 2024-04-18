END {
    for (i = length($0); i > 0; i--) {
        reversed = reversed substr($0, i, 1);
    }
    print reversed;
}
