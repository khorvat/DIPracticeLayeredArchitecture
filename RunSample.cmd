cls
@Echo off
echo.
echo Product list
echo.
curl http://localhost/DILA/api/cart/products
echo.
echo.
pause
cls
echo.
echo My Cart
echo.
curl http://localhost/DILA/api/cart/my-cart
echo.
echo.
pause
cls
echo.
echo My Cart Products
echo.
curl http://localhost/DILA/api/cart/my-cart/products
echo.
echo.
pause
cls
echo.
echo Add Product 1 To My Cart
echo.
curl --data '' http://localhost/DILA/api/cart/my-cart/products/1
echo.
echo.
pause
cls
echo.
echo My Cart with Added Product 1
echo.
curl http://localhost/DILA/api/cart/my-cart
echo.
echo.
pause
cls
echo.
echo Remove Product 1 From My Cart
echo.
curl -X DELETE http://localhost/DILA/api/cart/my-cart/products/1
echo.
echo.
pause
cls
echo.
echo My Cart with Removed Product 1
echo.
curl http://localhost/DILA/api/cart/my-cart
echo.
echo.
pause
cls
