import XCTest
import AppCenterXCUITestExtensions

class XCUITestDemoUITests: XCTestCase {
        
    override func setUp() {
        super.setUp()
                continueAfterFailure = true
        XCUIApplication().launch()

    }
    
    override func tearDown() {
        super.tearDown()
    }
    
    func testExample() {
        
        let app = XCUIApplication()
        let masterNavigationBar = app.navigationBars["Master"]
        masterNavigationBar.buttons["Add"].tap()
        masterNavigationBar.buttons["Edit"].tap()
        
    }
    
}
