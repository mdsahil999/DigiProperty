import { xyzTemplatePage } from './app.po';

describe('xyz App', function() {
  let page: xyzTemplatePage;

  beforeEach(() => {
    page = new xyzTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
