#include <stdio.h>
#include <stdlib.h>
#include "stack.h"

void push(StackNode** top, int data) {
    StackNode* new_node = malloc(sizeof(StackNode));
    new_node->data = data;
    new_node->next = *top;
    *top = new_node;
}

int pop(StackNode** top) {
    if (*top == NULL) return -1;
    StackNode* temp = *top;
    int data = temp->data;
    *top = temp->next;
    free(temp);
    return data;
}

int peek(StackNode* top) {
    if (top == NULL) return -1;
    return top->data;
}

int is_stack_empty(StackNode* top) {
    return top == NULL;
}

void print_stack(StackNode* top) {
    while (top) {
        printf("%d -> ", top->data);
        top = top->next;
    }
    printf("NULL\n");
}

void free_stack(StackNode* top) {
    while (top) {
        StackNode* temp = top;
        top = top->next;
        free(temp);
    }
}
