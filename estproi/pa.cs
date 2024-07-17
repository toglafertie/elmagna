public ActionResult MyAction()
{
    string myString = "Hello, world!";
    return Content(myString, "text/plain");
}
