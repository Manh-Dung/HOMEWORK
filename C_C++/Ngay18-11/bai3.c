#include<stdio.h>

void swap(int *a, int *b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}

void sapXepMang(int a[]){
    int left = 0;
    int right = 8;
    int mid;
    int i, j, x;

    for (i = 0; i < 8; i++) {
        for (j = i + 1; j < 9; j++){
            if (a[i] > a[j]) {
                swap (&a[i], &a[j]);
            }
        }
    }
    mid = (right + left) / 2;
    if (a[mid] < 0) {
        left = mid + 1;
        for (i = left; i <= right; i++) {
            if (a[i] == 0) {
                for (j = i - mid; j >= 1; j--){
                    a[mid + j] = a[mid + j - 1];
                }
                a[mid] = 0;
            }  
        }
    }
    else if(a[mid] > 0){
        right = mid - 1;
        for (i = right; i >= left; i--) {
            if (a[i] == 0) {
                for (j = mid - i; j >= 1; j--){
                    a[mid - j] = a[mid - j + 1];
                }
                a[mid] = 0;
            }  
        }
    }
    
    left = mid + 1;
    right = 8;
    for (i = left; i < right; i++) {
        for (j = i + 1; j <= right; j++){
            if (a[i] < a[j]) {
                swap (&a[i], &a[j]);
            }
        }
    }

    for (x = 0; x < 9; x++){
        printf("%d ", a[x]);
    }

}

int main(){
    int a[9] = {3, 6, 1, -1, 0, 5, 8, 2, 4};
    sapXepMang(a);
    return 0;
}

// sap xep mang tang dan
// chen phan tu co gia tri bang 0 vao vi tri chinh giua
// sap xep cac phan tu dang sau phan tu chinh giua
