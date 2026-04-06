W04 Foundation Programs Design
Foundation Program #1: Abstraction using YouTube Videos
What is the program supposed to do?
The program is intended to control the inventory of YouTube videos. Every video will have attributes such as name, author, and duration. There is an option for users to comment on the video. The program will show the details of every video and also their comments, including the number of comments received.

Classes and their responsibilities

Video

Stores the data about the video and controls a list of comments
Is capable of counting the comments
Displays the details:

Member Variables	Methods
_title : string	GetTitle() : string
_author : string	GetAuthor() : string
_lengthSeconds : int	GetLength() : int
_comments : List<Comment>	AddComment(Comment comment)
GetNumberOfComments() : int
GetComments() : List<Comment>
Comment

Stores a single comment left by a viewer
Member Variables	Methods
_commenterName : string	GetCommenterName() : string
_text : string	GetText() : string
Class Diagram

┌─────────────────────────┐        ┌──────────────────────┐
│         Video           │        │       Comment        │
├─────────────────────────┤        ├──────────────────────┤
│ - _title : string       │1    *  │ - _commenterName     │
│ - _author : string      │────────│ - _text : string     │
│ - _lengthSeconds : int  │        ├──────────────────────┤
│ - _comments : List      │        │ + GetCommenterName() │
├─────────────────────────┤        │ + GetText()          │
│ + AddComment()          │        └──────────────────────┘
│ + GetNumberOfComments() │
│ + GetTitle/Author/Length│
└─────────────────────────┘

Program Flow

Program.cs
│
├── Create Video objects (title, author, length)
├── Create Comment objects and add to each Video
│
└── For each Video:
      ├── Display title, author, length
      ├── Display number of comments
      └── Loop through comments → display name + text

Foundation Program #2: Encapsulation Using Online Ordering
What is the function of the program?
This program demonstrates a product ordering application. It creates orders that consist of several products for various clients and calculates the total cost along with shipping. It also prints the packing slip for each item included in the order as well as a shipping label for the client's address.

Address

Stores a physical address and can determine if it is in the USA
Member Variables	Methods
_streetAddress : string	IsInUSA() : bool
_city : string	GetFullAddress() : string
_stateProvince : string	
_country : string	
Customer

Stores a customer name and their address
Member Variables	Methods
_name : string	GetName() : string
_address : Address	IsInUSA() : bool
GetFullAddress() : string
Product

Stores a single product's info and calculates its cost
Member Variables	Methods
_name : string	GetName() : string
_productId : string	GetProductId() : string
_price : double	GetTotalCost() : double
_quantity : int	
Order

Owns a list of products and a customer; generates labels and totals
Member Variables	Methods
_products : List<Product>	AddProduct(Product p)
_customer : Customer	GetTotalCost() : double
GetPackingLabel() : string
GetShippingLabel() : string
Class Diagram

┌──────────────┐     ┌──────────────┐     ┌──────────────┐
│    Order     │*   1│   Customer   │1   1│   Address    │
├──────────────┤─────├──────────────┤─────├──────────────┤
│ - _products  │     │ - _name      │     │ - _street    │
│ - _customer  │     │ - _address   │     │ - _city      │
├──────────────┤     ├──────────────┤     │ - _state     │
│ + GetTotal() │     │ + GetName()  │     │ - _country   │
│ + GetPacking │     │ + IsInUSA()  │     ├──────────────┤
│ + GetShipping│     └──────────────┘     │ + IsInUSA()  │
└──────┬───────┘                          │ + GetFull()  │
       │ *                                └──────────────┘
┌──────┴───────┐
│   Product    │
├──────────────┤
│ - _name      │
│ - _productId │
│ - _price     │
│ - _quantity  │
├──────────────┤
│ + GetTotal() │
│ + GetName()  │
│ + GetId()    │
└──────────────┘

Program Flow

Program.cs
│
├── Create Address objects
├── Create Customer objects (using Address)
├── Create Order objects (using Customer)
├── Create Product objects and add to Orders
│
└── For each Order:
      ├── Print GetPackingLabel()   → lists each product name + ID
      ├── Print GetShippingLabel()  → customer name + full address
      └── Print GetTotalCost()      → sum of products + $5 (USA) or $35 (international)

