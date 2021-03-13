#include <iostream>

using namespace std;

template <typename T>
class SinglyLinkedList {
private:
	struct Node {
		T* _data{};
		Node* _next{};
	};
public:
	Node* _head{};
	int count{};
	SinglyLinkedList() : _head(nullptr) {}

	void push_back(T data) {
		Node* newNode = new Node;
		if (_head==nullptr)
		{
			newNode->_data = new T(data);
			newNode->_next = nullptr;
			_head = newNode;
		}
		else if (_head->_next == nullptr) {
			newNode->_data = new T(data);
			newNode->_next = nullptr;
			_head->_next = newNode;
		}
		else {
			Node* temp = new Node;
			temp = _head;
			while (temp->_next != nullptr) {
				temp = temp->_next;
			}
			newNode->_data = new T(data);
			newNode->_next = nullptr;
			temp->_next = newNode;
		}
		count++;
	}

	void push_front(T data) {
		Node* newNode = new Node;
		if (_head == nullptr)
		{
			newNode->_data = new T(data);
			newNode->_next = nullptr;
			_head = newNode;
		}
		else{
			newNode->_data = new T(data);
			newNode->_next = _head;
			_head = newNode;
		}
		count++;
	}

	T peek_front() { return *_head->_data; }

	T peek_back() {
		Node* temp = new Node;
		temp = _head;
		while (temp->_next != nullptr) {
			temp = temp->_next;
		}
		return *temp->_data;
	}

	void pop_back() {
		Node* temp = new Node;
		temp = _head;
		while (temp->_next != nullptr) {
			temp = temp->_next;
		}
		temp = nullptr;
		count--;
	}

	void pop_front(){
		Node* temp = new Node;
		temp = _head;
		_head = temp->_next;
		count--;
	}

	void print() {
		Node* temp = new Node;
		temp = _head;
		while (temp != nullptr) {
			cout << *temp->_data << " ";
			temp = temp->_next;
		}
	}

	int size() { return count; }
};

int main() {
	SinglyLinkedList<int> lst;
	lst.push_back(1);

	return 0;
}