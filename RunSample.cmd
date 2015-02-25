cls
@Echo off

del src\Cart.WebAPI\Cart.WebAPI\bin\Cart.Repository.dll /Q
del src\Cart.WebAPI\Cart.WebAPI\bin\Cart.Service.dll /Q
cls
echo.
echo Product list
echo.
curl http://localhost:63924/api/cart/products
echo.
echo.
pause
cls
echo.
echo My Cart
echo.
curl http://localhost:63924/api/cart/my-cart
echo.
echo.
pause
cls
echo.
echo My Cart Products
echo.
curl http://localhost:63924/api/cart/my-cart/products
echo.
echo.
pause
cls
echo.
echo Add Product 1 To My Cart
echo.
curl --data '' http://localhost:63924/api/cart/my-cart/products/1
echo.
echo.
pause
cls
echo.
echo My Cart with Added Product 1
echo.
curl http://localhost:63924/api/cart/my-cart
echo.
echo.
pause
cls
echo.
echo Remove Product 1 From My Cart
echo.
curl -X DELETE http://localhost:63924/api/cart/my-cart/products/1
echo.
echo.
pause
cls
echo.
echo My Cart with Removed Product 1
echo.
curl http://localhost:63924/api/cart/my-cart
echo.
echo.
pause
cls
echo.
echo Try to Add Out of Stock Product to My Cart - Product 4
echo.
curl --data '' http://localhost:63924/api/cart/my-cart/products/4
echo.
echo.
pause
cls
echo.
echo Try to Add Deleted Product to My Cart - Product 5
echo.
curl --data '' http://localhost:63924/api/cart/my-cart/products/5
echo.
echo.
pause
cls
echo.
echo Try to Add Exp. Date Product to My Cart - Product 7
echo.
curl --data '' http://localhost:63924/api/cart/my-cart/products/7
echo.
echo.
pause
cls