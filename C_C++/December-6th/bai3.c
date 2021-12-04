#include<stdio.h>
#include<stdlib.h>
 
struct LinkedList {
    int data;
    struct LinkedList *next;
    struct LinkedList *prev;
};
 
typedef struct LinkedList *node; 
node head, tail;
 
node CreateNode(int value) {
    node temp;
    temp = (node)malloc(sizeof(struct LinkedList));
    temp->data = value;
    temp->prev = NULL;
    temp->next = NULL;
    return temp;
}
 
void AddTail(node head, node tail, int value) {
    node temp = CreateNode(value);
    if(head == NULL) {
        head = temp;
        tail = temp;
        return;
    }
    tail->next = temp;
    temp->prev = tail;
    tail = temp;
}

void AddHead(node head, node tail, int value){
    node temp = CreateNode(value); 
    if(head == NULL){
        head = temp; 
        tail = temp;
    }else{
        head->prev = temp;
        temp->next = head;
        tail = head;
        head = temp; 
    }
}

void Output() {
    printf("\nXuat danh sach theo chieu xuoi: \n");
    for(node p = head; p != NULL; p = p->next){
        printf("%5d ", p->data);
    }
    printf("\n");
}
 
void ReverseOutput() {
    printf("\nXuat danh sach theo chieu nguoc: \n");
    for(node p = tail; p != NULL; p = p->prev){
        printf("%5d ", p->data);
    }
    printf("\n");
}

void Input(){
    head = NULL;
    tail = NULL;
    int n, value;
    do{
        printf("\nNhap so luong phan tu n = ");
        scanf("%d", &n);
    }while(n <= 0);
 
    for(int i = 0; i < n; ++i){
        printf("\nNhap gia tri can them: ");
        scanf("%d", &value);
        AddTail(head, tail, value);
    }
}

int Length(){
    int length = 0;
    for(node p = head; p != tail->next; p = p->next){
        ++length;
    }
    return length;
}

// void sort(node head){
//     node tag = CreateNode(0);
//     node temp = CreateNode(0);
//     if (head == tail) return;

//     node left = CreateNode(0);
//     node right = CreateNode(0);
//     tag = head;
//     tag->next = NULL;
//     head = head->next;
//     while (head != NULL){
//         temp = head;
//         head = head->next;
//         head->prev = NULL;
//         temp->next = NULL;
//         if (temp->data >= tag->data) AddHead(left, temp->data);
//         else AddHead(right, temp->data);
//     }
//     sort(right);
//     if (right != NULL){
//         head = right;
//         tail->next = tag;
//         tag->prev = tail;
//     }
//     else {
//         tag->next = left;
//         left->prev = tail;
//         head = tag;   
//     }
//     sort(left);
//     if (left != NULL){
//         left->prev = tag;
//         tag->next = left;
//     }
//     else tag->next = NULL;
// }
 
int main() {
    printf("\nTao 1 danh sach lien ket: "); 
    Input();
    Output();
    ReverseOutput();

    printf("\nMang sau khi sap xep la: ");
    sort(head);
    Output();
}