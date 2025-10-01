#ifndef STACK_H
#define STACK_H

typedef struct StackNode {
    int data;
    struct StackNode* next;
} StackNode;

void push(StackNode** top, int data);
int pop(StackNode** top);
int peek(StackNode* top);
int is_stack_empty(StackNode* top);
void print_stack(StackNode* top);
void free_stack(StackNode* top);

#endif
