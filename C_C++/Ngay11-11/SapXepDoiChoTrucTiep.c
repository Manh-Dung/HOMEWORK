#include<stdio.h>

void swap(int *a, int *b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}

void sapXepMang(int arr[]) {   
    int stt = 0;
    for (int i = 0; i < 7; i++) {
        for (int j = i + 1; j < 8; j++) {
            if (arr[i] > arr[j]) {
                swap (&arr[i], &arr[j]);
                stt++;
                printf ("\n%d. Mang sau khi sap xep la: ", stt);
                for (int x = 0; x < 8; x++) {
                    printf ("%d ", arr[x]);
                }
            }
        }
    } 
}

int main() {
    int arr[8] = {7, 9, 10, -4, 5, 8, 2, 1};
    sapXepMang(arr);
    return 0;
}