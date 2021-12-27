var shoppingCart = (function() {
  // =============================
  // Private methods and propeties
  // =============================
  cart = [];
  
  // Constructor
  function Item(id, name , img, price, count, dongia) {
    this.id   = id;
    this.name = name;
    this.img = img;
    this.price = price;
    this.dongia = dongia;
    this.count = count;
  }
  
  // Save cart
  function saveCart() {
    sessionStorage.setItem('shoppingCart', JSON.stringify(cart));
  }
  
    // Load cart
  function loadCart() {
    cart = JSON.parse(sessionStorage.getItem('shoppingCart'));
  }
  if (sessionStorage.getItem("shoppingCart") != null) {
    loadCart();
  }
  

  // =============================
  // Public methods and propeties
  // =============================
  var obj = {};
  
  // Add to cart
  obj.addItemToCart = function(id, name , img , price, count, dongia) {
    for(var item in cart) {
      if(cart[item].id === id ) {
        cart[item].count ++;
        saveCart();
        return;
      }
    }
    var item = new Item(id, name, img , price, count, dongia);
    cart.push(item);
    saveCart();
  }
  // Set count from item
  obj.setCountForItem = function(name, count) {
    for(var i in cart) {
      if (cart[i].name === name) {
        cart[i].count = count;
        break;
      }
    }
  };
  // Remove item from cart
  obj.removeItemFromCart = function(id) {
      for(var item in cart) {
        if(cart[item].id === id) {
          cart[item].count --;
          if(cart[item].count === 0) {
            cart.splice(item, 1);
          }
          break;
        }
    }
    saveCart();
  }

  // Remove all items from cart
  obj.removeItemFromCartAll = function(id) {
    for(var item in cart) {
      if(cart[item].id === id) {
        cart.splice(item, 1);
        break;
      }
    }
    saveCart();
  }

  // Clear cart
  obj.clearCart = function() {
    cart = [];
    saveCart();
  }

  // Count cart 
  obj.totalCount = function() {
    var totalCount = 0;
    for(var item in cart) {
      totalCount += cart[item].count;
    }
    return totalCount;
  }

  // Total cart
  obj.totalCart = function() {
    var totalCart = 0;
    for(var item in cart) {
      totalCart += cart[item].price * cart[item].count;
    }
    return Number(totalCart.toFixed(0));
  }
  // discount
  obj.discount = function() {
    var discount = 0, m = 0;
    for(var item in cart) {
      discount += cart[item].price * cart[item].count;
      m = (discount*20)/100;
    }
    return Number(m.toFixed(0));
  }

  // List cart
  obj.listCart = function() {
    var cartCopy = [];
    for(i in cart) {
      item = cart[i];
      itemCopy = {};
      for(p in item) {
        itemCopy[p] = item[p];

      }
      itemCopy.total = Number(item.price * item.count).toFixed(0);
      cartCopy.push(itemCopy)
    }
    return cartCopy;
  }

  // cart : Array
  // Item : Object/Class
  // addItemToCart : Function
  // removeItemFromCart : Function
  // removeItemFromCartAll : Function
  // clearCart : Function
  // countCart : Function
  // totalCart : Function
  // listCart : Function
  // saveCart : Function
  // loadCart : Function
  return obj;
})();
var pro = [];

function saveproduct() {
  sessionStorage.setItem('shopping', JSON.stringify(pro));
}
  // Load cart
function loadproduct() {
  pro = JSON.parse(sessionStorage.getItem('shopping'));
}

// *****************************************
// Triggers / Events
// ***************************************** 
// Add item
$('.add-to-cart').click(function(event) {
  event.preventDefault();
  var id = $(this).data('id');
  var name = $(this).data('name');
  var img = $(this).data('img');
  var price = Number($(this).data('price'));
  var dongia = $(this).data('price');


  
  shoppingCart.addItemToCart(id, name,img, price,1, dongia);
  
  displayCart();
});

// Clear items
$('.clear-cart').click(function() {
  shoppingCart.clearCart();
    window.location.reload();
  displayCart();
});
  

function dathang(){
  alert("Bạn phải đăng nhập trước")
  location.href = 'login';

}
  function displayCart() {
    var cartArray = shoppingCart.listCart();
    var output = "";
    for(var i in cartArray) {
      output += "<tr class='text-center'>"
        + "<td><img src='" + cartArray[i].img + "' style='width:100px'></td>" 
        + "<td class='name-title'>" + cartArray[i].name + "</td>" 

        + "<td>" + cartArray[i].price + "₫</td>"
        + "<td><button class='minus-item cart-count input-group-addon btn btn-outline-primary' data-id='" + cartArray[i].id + "' data-name=" + cartArray[i].name + ">-</button>"
        +""
        +  "<button class='btn cart-count'>" +cartArray[i].count+"</button>" 
        + "<button class='plus-item cart-count btn btn-primary input-group-addon' data-id='" + cartArray[i].id + "'  data-name='" + cartArray[i].name + "'>+</button>"
        +"</td>"
        + "<td>" + cartArray[i].total+ "₫</td>"   
        + "<td><button class='delete-item btn btn-outline-danger' data-id='" + cartArray[i].id + "' data-name=" + cartArray[i].name + ">X</button></td>"
       
        +  "</tr>";
    }
    $('.show-cart-1').html(output);
    $('.total-cart').html(shoppingCart.totalCart());
    $('.total-count').html(shoppingCart.totalCount());

  }

  $('.show-cart-1').on("click", ".delete-item", function(event) {
    var id = $(this).data('id')
    var size = $(this).data('size')

    shoppingCart.removeItemFromCartAll(id,size);
    displayCart();
  })
  
  
  // -1
  $('.show-cart-1').on("click", ".minus-item", function(event) {
    var id = $(this).data('id')    
    var size = $(this).data('size')

    shoppingCart.removeItemFromCart(id,size);
    displayCart();
    
  })
  // +1
  $('.show-cart-1').on("click", ".plus-item", function(event) {
    var id = $(this).data('id')
    var size = $(this).data('size')

    shoppingCart.addItemToCart(id,'','','','',size);
    displayCart();
  })
  
  // Item count input
  $('.show-cart-1').on("change", ".item-count", function(event) {
     var id = $(this).data('id');
     var size = $(this).data('size');

     var count = Number($(this).val());
    shoppingCart.setCountForItem(id, count,size);
    displayCart();
  });
  displayCart();
  var info= [];
  var donhang =[];
  function Savedon(){
    localStorage.setItem('listdon',JSON.stringify(donhang))
    }

//lấy sản phẩm 
function loaddon(){
donhang = JSON.parse(localStorage.getItem('listdon'));
} 

if (localStorage.getItem("listdon") == null) {
Savedon();
}
var checkCart= function(data){
  console.log(data)
  if ((document.getElementById("inputnguoinhan").value=="")){
    $(".nguoinhan").css("display","block");
  }else{
    $(".nguoinhan").css("display","none");
  }
  if ((document.getElementById("inputsdt").value=="")){
    $(".sdt").css("display","block");
  }else{
    $(".sdt").css("display","none");
  }
  
  if ((document.getElementById("inputdiachi").value=="")){
    $(".diachi").css("display","block");
  }else{
    $(".diachi").css("display","none");
  }

  if ((document.getElementById("inputemail").value=="" )){
    $(".email").css("display","block");
  }
  else{
    $(".email").css("display","none");
  }
  if ((document.getElementById("inputnguoinhan").value!="")&&(document.getElementById("inputsdt").value!="")&&(document.getElementById("inputdiachi").value!="")&&(document.getElementById("inputemail").value!="")){
    
    
    infoCart(data);
 }
}
var add_don = function(){
 
      loaddon();
  var item = {
    id : donhang.length+1,
    user : document.getElementById("inputnguoinhan").value,
    phone:document.getElementById("inputsdt").value,
    address :document.getElementById("inputdiachi").value ,
    email: document.getElementById("inputemail").value,
    total :shoppingCart.totalCart(),
    ghichu: document.getElementById("inputghichu").value,
    trangthai : "Đang xử lí",
  }
  loaddon();
  donhang.push(item);
  
  Savedon();
}
 
 

  function xacnhan(){
    if(shoppingCart.listCart().length==0){
    alert("Giỏ hàng trống");
    location.reload();
    }
    else{
    $(".thongtins").css("display","none");
    $("#xacnhandathang").css("display","block")
    }
  }
  function infoCart(data){
    
    var arr=shoppingCart.listCart();
    console.log(arr);
    document.getElementById("inputnguoinhan1").innerText = document.getElementById("inputnguoinhan").value;

    document.getElementById("inputsdt1").innerText=document.getElementById("inputsdt").value;

    document.getElementById("inputdiachi1").innerText = document.getElementById("inputdiachi").value;
        

    document.getElementById("inputemail1").innerText= document.getElementById("inputemail").value;

    document.getElementById("inputghichu1").innerText= document.getElementById("inputghichu").value;

    document.getElementById("inputthanhtoan1").innerText= document.getElementById("inputthanhtoan").value;


      var thanhtoan= document.getElementById("inputthanhtoan").value;
      console.log(thanhtoan)

        $(".cartt").attr("data-dismiss", "modal");
        $(".thongtins").css("display","block");
      }





      function submitdonhang(){
        var arr=shoppingCart.listCart();
        console.log(arr)
        var ten=document.getElementById("inputnguoinhan1").innerText;
        var sdt=document.getElementById("inputsdt1").innerText;
        var diachi= document.getElementById("inputdiachi1").innerText;
        var note= document.getElementById("inputghichu1").innerText;
        var email = document.getElementById("inputemail1").innerText;
        var thanhtoan= document.getElementById("inputthanhtoan").value;
        console.log(thanhtoan);
        var send={
          ten: ten,
          sdt : sdt,
          diachi: diachi,
          note :note,
          email: email,          
          arr : arr,
          thanhtoan:thanhtoan
        }

        
        fetch('http://localhost:3000/cart',{
          method:'POST',
          headers: {'Content-type':'application/json'}, 
          body: JSON.stringify(send),
        })
      .then(function(respone){
        return respone.json();
      })
      .then(function(notice){
        
        if(notice==='success'){
          alert("Đặt hàng thành công")

          window.location.replace("http://localhost:3000/");

        }
      })
// Đơn hàng---

      
    
    }




