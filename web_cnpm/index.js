const express = require('express')
const mssql=require('mssql/msnodesqlv8');
const bodyParser = require('body-parser');
const shortid = require('shortid');
const path=require('path');
var session = require('express-session')

const port=3000;
const app = express()
app.use(bodyParser.urlencoded({ extended: false }));
app.use(express.json({limit :'1mb'}));
app.set('view engine', 'ejs');
app.set('views',path.join(__dirname,'/view'))
console.log(__dirname);
app.use(session({
  secret: 'keyboard cat',
  resave: false,
  saveUninitialized: true,
}))



app.use(express.static(path.join(__dirname,'/public/style')))
app.use(express.static(path.join(__dirname,'/public/img')))
app.use(express.static(path.join(__dirname,'/public/js')))

const sqlConfig = {
 
  server:"DESKTOP-9GIEK94\\SQL",
  database: "QUANLYKHO",
  driver:"msnodesqlv8",
 
  options: {
   trustedConnection:true
  }
};





app.get('/', function (req, res) {

  mssql.connect(sqlConfig,function(err){
    if(err){
      console.log(err);
    }
    var request = new mssql.Request();

        request.query("Select * from Web_SanPham",function(err,record){
        if(err){
            console.log(err);
    }
    else{
      console.log(record.recordset[0].ThuongHieu)
        res.render('homepage',{result: record.recordset});
    }
  });
  })

})

app.get('/detail',function(req,res){
  res.render('detail');
})


app.get('/login',function(req,res){
  if(req.session.userID){
    console.log(req.session.userID)
    res.redirect('/');
  }
  else{
    res.render('login');
  }
})


app.post('/login',function(req,res){
  mssql.connect(sqlConfig,function(err){
    if(err){
      console.log(err);
    }
    var request = new mssql.Request();

        request.query(`Select * from Account where TaiKhoan = '${req.body.taikhoan}'`,function(err,record){
        if(err){
            console.log(err);
    }
    else{
      if(record.recordset.length!=0){
        console.log(record.recordset)
        req.session.userID=record.recordset[0].TaiKhoan;

        res.redirect('/')
      }
      else{
        res.redirect('login');
      }
    }
  });
  })
})

app.get('/logout',function(req,res){
  req.session.destroy();
  res.redirect('login')
})

app.get('/cart',function(req,res){
  if(!req.session.userID){
    res.render('cart')
  }
  mssql.connect(sqlConfig,function(err){
    if(err){
      console.log(err);
    }
    var request = new mssql.Request();

        request.query(`Select * from Account where TaiKhoan = '${req.session.userID}'`,function(err,record){
        if(err){
            console.log(err);
    }
    else{
        console.log(record.recordset)
        res.render('cart',{result: record.recordset});
    }
  });
  })
})

app.post('/cart',function(req,res){
  console.log(req.body)

  let today = new Date().toISOString().slice(0, 10)
 

  console.log(today);
  var iddon=shortid.generate();


  mssql.connect(sqlConfig,function(err){
    if(err){
      console.log(err);
    }
    for(var x=0;x<req.body.arr.length;x++){

    var request = new mssql.Request();

        request.query(`INSERT INTO DatHang VALUES ('${iddon}',N'${req.body.ten}',N'${req.body.diachi}','${req.body.sdt}',N'${req.body.thanhtoan}','${today}','${req.body.arr[x].id}',N'${req.body.arr[x].name}','${req.body.arr[x].count}','${req.body.arr[x].price}','${req.body.arr[x].total}')`,function(err,record){
        if(err){
            console.log(err);
        }
         else{
              console.log(record)
         }
        })
      } 
    })
    res.json('success');

  });
  
 

app.listen(3000,function(){console.log(`listen at portssss http://localhost/${port}`)});