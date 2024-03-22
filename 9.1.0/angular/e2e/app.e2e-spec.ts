import { FactAngularTemplatePage } from './app.po';

describe('FactAngular App', function() {
  let page: FactAngularTemplatePage;

  beforeEach(() => {
    page = new FactAngularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
