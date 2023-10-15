int Reverse(int x) {
    var result = 0;
    var prev = 0;
    while(x != 0){
        prev = result;
        result = result*10 + x%10;
        x = x/10;
    }
    return result/10 == prev ? result : 0;
}