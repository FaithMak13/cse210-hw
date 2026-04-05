Definition of Encapsulation and Importance

Encapsulation is one of the four basic concepts of object-oriented programming (OOP). Encapsulation refers to the technique of putting data attributes and functions that act on those data inside the same unit such as a class while making some parts of the unit inaccessible. Encapsulation is known as the technique of making the internal workings of an object hidden, thus, only allowing its state changes to occur through certain procedures.

Why is it Important?

An important function of encapsulation is in offering data protection and secure access. By declaring data as private and making only the required ones accessible through getters and setters, no code outside the object can place the object in an unexpected or invalid state. Thus, you have fewer chances to break the program when debugging and maintaining it since you know for sure how an object's data can change.

Use of Encapsulation

Take an example of the account balance of a bank account. Balance of the account should not be able to be directly assigned by anyone other than the class. Otherwise, there will be the possibility of setting a negative balance, which should not happen in real-life cases.

Code Example: 

class BankAccount {
  private balance: number;

  constructor(balance: number) {
    this.balance = balance;
  }

  deposit(balance: number): void {
    if (balance > 0) {
      this.balance += balance;
    }
  }

  withdraw(balance: number): void {
    if (balance > 0 && balance <= this.balance) {
      this.balance -= balance;
    }
  }

  getBalance(): number {
    return this.balance;
  }
}