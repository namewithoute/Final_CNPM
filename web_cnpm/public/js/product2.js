var product = [];
var pro = [];

function saveproduct() {
    sessionStorage.setItem('shopping', JSON.stringify(pro));
  }
    // Load cart
  function loadproduct() {
    pro = JSON.parse(sessionStorage.getItem('shopping'));
  }
  
  var chuyen = function() {
    pro=[];
    saveproduct();    
    window.location = "/";
  };
  $('.proo').click(function(event) {
    event.preventDefault();
    var id = $(this).data('id');
    var name = $(this).data('name');
    var img = $(this).data('img');
    var xuatxu=$(this).data('xuatxu');
    var thuonghieu=$(this).data('thuonghieu');
    var price = Number($(this).data('price'));
    var mota=$(this).data('mota');

  

    var item ={
       id,
       name,
       img,
      price,
      mota,
      xuatxu,
      thuonghieu,
   }
    pro.push(item);
    saveproduct();
   window.location="detail";    
  });
  
  if (sessionStorage.getItem("shopping") != null) {
    loadproduct();
  }
  
function Save(product){
    localStorage.setItem('listProduct',JSON.stringify(product))
}
//lấy sản phẩm 
function load(){
   product = JSON.parse(localStorage.getItem('listProduct'));
} 
//xuất sản phẩm ra html
if (localStorage.getItem("listProduct") != null) {
load();
}
var ProductLocal = function(){
    loadproduct();
    const formatter = new Intl.NumberFormat('en-US', {
      style: 'currency',
      currency: 'VND',
      minimumFractionDigits: 0
    })
    var Cproduct ="";
    var data1 =pro[pro.length-1];
    console.log(data1.thuonghieu);
    Cproduct+='<h3>Sản phẩm/'+data1.name+'</h3>';
    Cproduct+='<div class="sanpham" style="display: flex;">';
    Cproduct+='<div class="hinhanh mt-3" >';
    Cproduct+='<img src="'+data1.img+'" alt="" style="width: 90%;">';
    Cproduct+='</div>';
    Cproduct+='<div class="content mt-3">';
    Cproduct+='<div class="title" style="border-bottom: 2px solid #dddddd; padding-bottom: 2px;">';
    Cproduct+='<span class="title-name h5">'+data1.name+' <br> </span> ';
    Cproduct+='<span class="title-ma">Mã sản phẩm: <b>'+data1.id+' </b> <br> </span> ';
    Cproduct+='<span class="title-trangthai">Còn hàng </span> ';
    
    Cproduct+='</div> ';
    Cproduct+='<div class="price" style="margin-top: 10px; font-weight: 900; font-size: x-large;">'+formatter.format(data1.price)+'</div>';
    Cproduct+= '<div class="p-transpot"> <div class="p-t1"><p>Phương thức vận chuyển:</p></div> <div class="p-t2"><p><i class="fas fa-shipping-fast"></i>Vận chuyển bằng dịch vụ GHTK</p></div> </div>';
    Cproduct+='<div class="p-t1"><p>Xuất xứ: '+data1.xuatxu+' </p></div>';
    Cproduct+='<div class="p-t1"><p>Thương hiệu: '+data1.thuonghieu+' </p></div>';

    Cproduct+='<div class="form"> <label class="p-size" style="font-weight: bold;"></label>';
    Cproduct+='<div class="p-size-content">';

  
    
    Cproduct+='<button style="margin-top: 10px; width: 100%;" class="btn btn-primary add-to-cart add-cart  themhang"  data-id="'+data1.id+'" data-name="'+data1.name+'" data-size="1" data-img="'+data1.img+'" data-price="'+data1.price+'" >Thêm vào giỏ</button>';
  
  
    
    Cproduct+='</div></div>';
    // Cproduct+='<button style="margin-top: 10px; width: 100%;" class="btn btn-primary add-to-cart add-cart  themhang"  data-id="'+data1.id+'" data-name="'+data1.name+'" data-size="'+123+'" data-img="'+data1.img+'" data-price="'+data1.price+'">Thêm vào giỏ</button>';
    Cproduct+='<div class="content-footer" style="margin-top: 20px;">';
    Cproduct+='<div class="giaohang" style="display: flex;">';
    Cproduct+='<div class="giaohang-content">';
   
    Cproduct+='</div>';      
    Cproduct+='</div>';
    Cproduct+='<div class="giaohang" style="display: flex;">';
    
    Cproduct+='</div>';
    Cproduct+='<div class="giaohang" style="display: flex;">';
    Cproduct+='<div><i class="fas fa-phone-alt" style="margin-right: 5px; margin-top: 5px;"></i></div>';
    Cproduct+='<div class="giaohang-content">';
    Cproduct+='<h4>TỔNG ĐÀI BÁN HÀNG 1800 1162</h4>';
    Cproduct+='<p>(Miễn phí từ 8h30 - 21:30 mỗi ngày)</p>';
    Cproduct+='</div>        ';   
    Cproduct+='</div>';
    Cproduct+='</div>';
    Cproduct+='</div>';
    Cproduct+='</div>';
    Cproduct+= ` <div class="p-bottom">
    <div class="p-bottom-big">
        <div class="p-bottom-title">
            <div class="p-bottom-title-item"><p>Detail</p></div>
        </div>
        <div class="p-bottom-content">
            <div class="p-bottom-content-chitiet">
              ${data1.mota}
            </div>
        </div>
    </div>
</div>`

    document.getElementById("chitiet").innerHTML =Cproduct; 
    }
    ProductLocal();

function checkradio(){
  const rbs = document.querySelectorAll('input[name="gender"]');
            let selectedValue;
            for (const rb of rbs) {
                if (rb.checked) {
                    selectedValue = rb.value;
                    break;
                }
            }
            return selectedValue;
}