#include <stdio.h>
#include <stdlib.h>
#include "queue.h"

Queue* create_queue() {
    Queue* q = malloc(sizeof(Queue));
    q->front = q->rear = NULL;
    return q;
}

void enqueue(Queue* q, int data) {
    QueueNode* new_node = malloc(sizeof(QueueNode));
    new_node->data = data;
    new_node->next = NULL;
    if (q->rear == NULL) {
        q->front = q->rear = new_node;
        return;
    }
    q->rear->next = new_node;
    q->rear = new_node;
}

int dequeue(Queue* q) {
    if (q->front == NULL) return -1;
    QueueNode* temp = q->front;
    int data = temp->data;
    q->front = q->front->next;
    if (q->front == NULL)
        q->rear = NULL;
    free(temp);
    return data;
}

int is_queue_empty(Queue* q) {
    return q->front == NULL;
}

void print_queue(Queue* q) {
    QueueNode* temp = q->front;
    while (temp) {
        printf("%d -> ", temp->data);
        temp = temp->next;
    }
    printf("NULL\n");
}

void free_queue(Queue* q) {
    while (!is_queue_empty(q)) {
        dequeue(q);
    }
    free(q);
}
